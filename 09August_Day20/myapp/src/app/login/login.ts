import { Component } from '@angular/core';
import { Input,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  @Input() cpt:string=""
  @Output() login = new EventEmitter<object>();

  userName:string=''
  password:string=''

  onLogin(){
    
  }
}
