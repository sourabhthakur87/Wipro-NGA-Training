import { DatePipe, NgIf } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-result',
  imports: [DatePipe,NgIf],
  templateUrl: './result.html',
  styleUrl: './result.css'
})
export class Result {

  historyData: any[] = [];

  ngOnInit() {
    const stored = localStorage.getItem("history");
    this.historyData = stored ? JSON.parse(stored) : [];
  }
}
