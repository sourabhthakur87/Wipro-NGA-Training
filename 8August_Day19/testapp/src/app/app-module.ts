import { NgModule, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { FileOps } from './file-ops/file-ops';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    App,
    FileOps
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule  // Add this line
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection()
  ],
  bootstrap: [App]
})
export class AppModule { }
