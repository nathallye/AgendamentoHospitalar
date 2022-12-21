import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HospitalDetalheComponent } from './hospital-detalhe.component';

describe('HospitalDetalheComponent', () => {
  let component: HospitalDetalheComponent;
  let fixture: ComponentFixture<HospitalDetalheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HospitalDetalheComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HospitalDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
