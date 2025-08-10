import { NgModule, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Header } from './component/header/header';
import { CreateTodo } from './component/create-todo/create-todo';
import { Home } from './component/home/home';
import { FormsModule } from '@angular/forms';
import { EditToDo } from './component/edit-to-do/edit-to-do';

@NgModule({
  declarations: [
    App,
    Header,
    CreateTodo,
    Home,
    EditToDo,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection()
  ],
  bootstrap: [App]
})
export class AppModule { }
