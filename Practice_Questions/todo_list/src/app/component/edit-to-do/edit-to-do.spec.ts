import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditToDo } from './edit-to-do';

describe('EditToDo', () => {
  let component: EditToDo;
  let fixture: ComponentFixture<EditToDo>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditToDo]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditToDo);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
