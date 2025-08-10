import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
  todoList: any
  constructor() {
    let x = localStorage.getItem('todoList')
    if (x) {
      this.todoList = JSON.parse(x)
    }
  }

  deleteTodo(id: any) {
    this.todoList = this.todoList.filter((todo: { id: any; }) => todo.id !== id);
    localStorage.setItem('todoList', JSON.stringify(this.todoList));
  }

  changeStatus(id: number) {
    const todo = this.todoList.find((t: { id: number }) => t.id === id);
    if (todo) {
      todo.status = todo.status === 'pending' ? 'done' : 'pending';
      localStorage.setItem('todoList', JSON.stringify(this.todoList));
    }
  }
}
