import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConnaissanceDetailsComponent } from './connaissance-details.component';

describe('ConnaissanceDetailsComponent', () => {
  let component: ConnaissanceDetailsComponent;
  let fixture: ComponentFixture<ConnaissanceDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConnaissanceDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConnaissanceDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
