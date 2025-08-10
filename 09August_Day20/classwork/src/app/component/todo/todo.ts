import { Component } from '@angular/core';

// Define the TodoItem interface
interface TodoItem {
  work: string;
  status: boolean;
  id: number;
}

@Component({
  selector: 'app-todo',
  standalone: false,
  templateUrl: './todo.html',
  styleUrls: ['./todo.css'] // Corrected 'styleUrl' to 'styleUrls'
})
export class Todo {
  todo: TodoItem[] = []; // Corrected initialization of todo array
  mytodo: TodoItem[] = []; // Array for storing todos from localStorage
  inputValue = ""; // Input value for new Todo
  id = 1; // To track the next id for new todo items

  // Capture input value from the user
  getInput(event: Event) {
    this.inputValue = (event.target as HTMLInputElement).value;
  }

  // Create a new Todo and add it to the todo array
  createToDo() {
    if (this.inputValue.trim()) { // Ensure it's not just empty spaces
      const newTodo: TodoItem = {
        work: this.inputValue,
        status: false,
        id: this.id
      };
      this.todo.push(newTodo);
      console.log(this.todo);
      this.id = this.id + 1 // Increment id for the next todo

      this.savetoStorage(); // Save to localStorage
      this.inputValue = ""; // Clear the input field
    }
  }

  // Save todo array to localStorage
  savetoStorage() {
    localStorage.setItem('todolist', JSON.stringify(this.todo));

    // Retrieve and parse the stored todos from localStorage
    const todos = localStorage.getItem('todolist');
    if (todos) {
      this.mytodo = JSON.parse(todos); // Update mytodo array with parsed todos
    }
  }

  // Load todos from localStorage (optional function)
  // getTodoList() {
  //   const todos = localStorage.getItem('todolist');
  //   if (todos) {
  //     this.mytodo = JSON.parse(todos); // Update mytodo with saved todos
  //     console.log(this.mytodo); // Log the todos
  //   }
  // }

  deleteTodo(id: number) {
    this.todo = this.todo.filter(item => item.id !== id)
    this.savetoStorage()
  }
}
