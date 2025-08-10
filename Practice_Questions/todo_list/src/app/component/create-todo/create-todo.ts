import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-create-todo',
  standalone: false,
  templateUrl: './create-todo.html',
  styleUrls: ['./create-todo.css'] // ✅ fix typo if needed
})
export class CreateTodo {

  todoList: any[] = [];

  constructor() {
    const storedTodos = localStorage.getItem('todoList'); // ✅ consistent key
    if (storedTodos) {
      this.todoList = JSON.parse(storedTodos);
    }
  }

  addDetails(form: NgForm) {
    const todoValue = form.value.todo?.trim(); // get the todo text input
    if (!todoValue) return; // ignore empty input

    const newTodo = {
      id:this.todoList.length+1,
      todo: todoValue,
      status: 'pending'
    };

    this.todoList.push(newTodo);
    localStorage.setItem('todoList', JSON.stringify(this.todoList)); // ✅ consistent key
    form.reset(); // optional: clears input after submission
  }
}
