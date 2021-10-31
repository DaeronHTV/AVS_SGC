import { TestBed } from '@angular/core/testing';

import { SCGApiService } from './scgapi.service';

describe('SCGApiService', () => {
  let service: SCGApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SCGApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
