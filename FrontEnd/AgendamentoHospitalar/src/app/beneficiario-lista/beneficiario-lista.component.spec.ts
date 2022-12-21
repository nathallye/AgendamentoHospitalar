import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeneficiarioListaComponent } from './beneficiario-lista.component';

describe('BeneficiarioListaComponent', () => {
  let component: BeneficiarioListaComponent;
  let fixture: ComponentFixture<BeneficiarioListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeneficiarioListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeneficiarioListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
