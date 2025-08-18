import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
  selectStatus: string = 'all';
  todoList: any[] = [];
  filteredTodoList: any[] = [];

  constructor() {
    const x = localStorage.getItem('todoList');
    if (x) {
      this.todoList = JSON.parse(x);
    }
    this.filterTodos();
  }

  filterTodos() {
    if (this.selectStatus === 'pending' || this.selectStatus === 'done') {
      this.filteredTodoList = this.todoList.filter((item: { status: string }) => item.status === this.selectStatus);
    } else {
      this.filteredTodoList = this.todoList;
    }
  }

  deleteTodo(id: any) {
    this.todoList = this.todoList.filter((todo: { id: any }) => todo.id !== id);
    localStorage.setItem('todoList', JSON.stringify(this.todoList));
    this.filterTodos();
  }

  changeStatus(id: number) {
    const todo = this.todoList.find((t: { id: number }) => t.id === id);
    if (todo) {
      todo.status = todo.status === 'pending' ? 'done' : 'pending';
      localStorage.setItem('todoList', JSON.stringify(this.todoList));
      this.filterTodos();
    }
  }
}
