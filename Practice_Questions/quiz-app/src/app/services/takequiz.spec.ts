import { TestBed } from '@angular/core/testing';

import { Takequiz } from './takequiz';

describe('Takequiz', () => {
  let service: Takequiz;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Takequiz);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
