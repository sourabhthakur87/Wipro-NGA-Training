import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Groupform } from './groupform';

describe('Groupform', () => {
  let component: Groupform;
  let fixture: ComponentFixture<Groupform>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Groupform]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Groupform);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
