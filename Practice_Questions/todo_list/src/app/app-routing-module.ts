import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateTodo } from './component/create-todo/create-todo';
import { Home } from './component/home/home';
import { EditToDo } from './component/edit-to-do/edit-to-do';

const routes: Routes = [
  { path: "createtodo", component: CreateTodo },
  { path: "", component: Home },
  { path: "edit/:id", component: EditToDo }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
