import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FileOps } from './file-ops';

describe('FileOps', () => {
  let component: FileOps;
  let fixture: ComponentFixture<FileOps>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FileOps]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FileOps);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
