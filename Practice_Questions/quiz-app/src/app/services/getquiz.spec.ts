import { TestBed } from '@angular/core/testing';

import { Getquiz } from './getquiz';

describe('Getquiz', () => {
  let service: Getquiz;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Getquiz);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
