import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-course-details',
  standalone: false,
  templateUrl: './course-details.html',
  styleUrl: './course-details.css'
})
export class CourseDetails {
  @Input() course: any;
}
