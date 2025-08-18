import { Component } from '@angular/core';

@Component({
  selector: 'app-stylecomponent',
  standalone: false,
  templateUrl: './stylecomponent.html',
  styleUrl: './stylecomponent.css'
})
export class Stylecomponent {
  color = 'chocolate'
  changeColor(val: string) {
    this.color = val
  }
}
