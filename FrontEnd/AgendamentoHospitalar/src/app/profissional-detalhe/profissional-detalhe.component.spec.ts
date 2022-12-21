import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfissionalDetalheComponent } from './profissional-detalhe.component';

describe('ProfissionalDetalheComponent', () => {
  let component: ProfissionalDetalheComponent;
  let fixture: ComponentFixture<ProfissionalDetalheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfissionalDetalheComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfissionalDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
