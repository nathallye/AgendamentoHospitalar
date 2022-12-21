import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendamentoDetalheComponent } from './agendamento-detalhe.component';

describe('AgendamentoDetalheComponent', () => {
  let component: AgendamentoDetalheComponent;
  let fixture: ComponentFixture<AgendamentoDetalheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendamentoDetalheComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgendamentoDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
