import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TampletForm } from './tamplet-form';

describe('TampletForm', () => {
  let component: TampletForm;
  let fixture: ComponentFixture<TampletForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TampletForm]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TampletForm);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
