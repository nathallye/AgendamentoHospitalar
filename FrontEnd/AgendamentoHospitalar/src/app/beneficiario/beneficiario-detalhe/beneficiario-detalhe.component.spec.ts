import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeneficiarioDetalheComponent } from './beneficiario-detalhe.component';

describe('BeneficiarioDetalheComponent', () => {
  let component: BeneficiarioDetalheComponent;
  let fixture: ComponentFixture<BeneficiarioDetalheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeneficiarioDetalheComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeneficiarioDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
