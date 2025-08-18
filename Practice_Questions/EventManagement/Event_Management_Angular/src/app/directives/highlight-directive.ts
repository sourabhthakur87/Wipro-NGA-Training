import { Directive, ElementRef, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appHighlightDirective]',
  standalone: false
})
export class HighlightDirective implements OnInit {

  @Input() appHighlightDirective: number = 0;
  constructor(private el: ElementRef) { }

  ngOnInit(): void {
    if (this.appHighlightDirective > 2000) {
      this.el.nativeElement.classList.add('highlight');
    }
  }

}
