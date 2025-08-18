import { NgModule, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { ClassStyle } from './component/class-style/class-style';
import { Stylecomponent } from './component/stylecomponent/stylecomponent';
import { MyPipes } from './component/my-pipes/my-pipes';
import { ReversepipePipe } from './pipe/reversepipe-pipe';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CurrencyConverter } from './component/currency-converter/currency-converter';

@NgModule({
  declarations: [
    App,
    ClassStyle,
    Stylecomponent,
    MyPipes,
    ReversepipePipe,
    CurrencyConverter
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection()
  ],
  bootstrap: [App]
})
export class AppModule { }
