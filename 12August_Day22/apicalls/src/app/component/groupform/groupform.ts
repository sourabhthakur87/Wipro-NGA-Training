import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { noSpacesValidator } from '../../Validator/spaceValidator';

@Component({
  selector: 'app-groupform',
  standalone: false,
  templateUrl: './groupform.html',
  styleUrl: './groupform.css',
})
export class Groupform {
    loginForm = new FormGroup({
      email : new FormControl("",[Validators.required,Validators.email,noSpacesValidator()]),
      password: new FormControl("",[Validators.required,Validators.minLength(6)])
    })

    onSubmit(){
      if(this.loginForm.valid){
        console.log(this.loginForm.value);
      }
      else{
        this.loginForm.markAllAsTouched()
      }
    }
}
