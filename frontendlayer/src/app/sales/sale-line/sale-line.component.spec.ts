import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SaleLineComponent } from './sale-line.component';

describe('SaleLineComponent', () => {
  let component: SaleLineComponent;
  let fixture: ComponentFixture<SaleLineComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaleLineComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaleLineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
