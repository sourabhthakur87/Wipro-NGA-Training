import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyPipes } from './my-pipes';

describe('MyPipes', () => {
  let component: MyPipes;
  let fixture: ComponentFixture<MyPipes>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MyPipes]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MyPipes);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
