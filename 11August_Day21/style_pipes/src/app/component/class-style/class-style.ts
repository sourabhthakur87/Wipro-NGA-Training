import { Component } from '@angular/core';

@Component({
  selector: 'app-class-style',
  standalone: false,
  templateUrl: './class-style.html',
  styleUrl: './class-style.css'
})
export class ClassStyle {
  status = false

  UpdateStatus(){
    this.status = !this.status
    console.log(this.status);
    
  }
}
