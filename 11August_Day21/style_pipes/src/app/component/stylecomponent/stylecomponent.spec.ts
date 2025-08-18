import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Stylecomponent } from './stylecomponent';

describe('Stylecomponent', () => {
  let component: Stylecomponent;
  let fixture: ComponentFixture<Stylecomponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Stylecomponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Stylecomponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
