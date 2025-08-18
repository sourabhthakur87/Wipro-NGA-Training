import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClassStyle } from './class-style';

describe('ClassStyle', () => {
  let component: ClassStyle;
  let fixture: ComponentFixture<ClassStyle>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ClassStyle]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClassStyle);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
