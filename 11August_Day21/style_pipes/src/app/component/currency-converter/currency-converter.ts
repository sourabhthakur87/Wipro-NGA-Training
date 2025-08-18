import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-currency-converter',
  standalone: false,
  templateUrl: './currency-converter.html',
  styleUrl: './currency-converter.css'
})
export class CurrencyConverter {

  num: number | any
  converter = new FormGroup({
    currency: new FormControl()
  })
  onSubmit() {
    this.num = this.converter.value
    console.log(this.num.currency);
  }
}
