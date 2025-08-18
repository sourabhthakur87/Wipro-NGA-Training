import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-course-list',
  standalone: false,
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {
  @Input() courses: any[] = [];
  @Output() courseSelected = new EventEmitter<any>();

  selectCourse(course: any) {
    this.courseSelected.emit(course);
  }
}
