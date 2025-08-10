import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-edit-to-do',
  standalone: false,
  templateUrl: './edit-to-do.html',
  styleUrls: ['./edit-to-do.css']
})

export class EditToDo {
  todoList: any[] = [];
  todo: any = { todo: '', status: 'pending', id: null };

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    const stored = localStorage.getItem('todoList');
    if (stored) {
      this.todoList = JSON.parse(stored);
    }

    const id = +this.route.snapshot.paramMap.get('id')!;
    const found = this.todoList.find(t => t.id === id);

    if (found) {
      this.todo = { ...found }; // pre-fill form
    }
  }

  editToDo(form: NgForm) {
    const index = this.todoList.findIndex(t => t.id === this.todo.id);
    if (index !== -1) {
      // Always keep status as "pending"
      this.todoList[index] = {
        ...this.todo,
        status: 'pending'
      };

      localStorage.setItem('todoList', JSON.stringify(this.todoList));
      this.router.navigate(['/']); // back to home
    }
  }
}
