import { Component } from '@angular/core';

@Component({
  selector: 'app-tamplet-form',
  standalone: false,
  templateUrl: './tamplet-form.html',
  styleUrl: './tamplet-form.css'
})
export class TampletForm {
  formData(val:any){
    console.log(val.value);
    
  }
}
