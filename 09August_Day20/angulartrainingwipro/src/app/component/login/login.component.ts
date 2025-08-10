import { Component,Input, Output, EventEmitter,signal} from '@angular/core';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
 @Input() caption: string = '';
 @Output() login = new EventEmitter<object>();
 count = signal(0);
 increment() {
    this.count.update(value => value + 1);
 }
 decrement() {
    this.count.update(value => value - 1);
 }
 reset() {
    this.count.set(0);
 }
  img = 'https://angular.io/assets/images/logos/angular/angular.png';
  username: string = '';
  password: string = '';
  col: number = 2;
  user:{}={}
  onLogin() {
    this.user = {
      username: this.username,
      password: this.password
    };
    console.log("Username: ", this.username, "Password: ", this.password);
    this.login.emit(this.user);
  }

}
