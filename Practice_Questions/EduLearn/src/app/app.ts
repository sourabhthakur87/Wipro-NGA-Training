import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
   selectedCourse: any = null;

  courses = [
    { id: 1, title: 'Angular Basics', description: 'Learn Angular step by step.' },
    { id: 2, title: 'TypeScript Fundamentals', description: 'Master TypeScript for Angular.' },
    { id: 3, title: 'RxJS Deep Dive', description: 'Handle async programming in Angular.' }
  ];

  onCourseSelected(course: any) {
    this.selectedCourse = course;
  }
}
