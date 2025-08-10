import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('myapp');
  caption = "This is sourabh thakur"

  login(user:object){
    console.log("Login User Is", user);
    
  }
}
