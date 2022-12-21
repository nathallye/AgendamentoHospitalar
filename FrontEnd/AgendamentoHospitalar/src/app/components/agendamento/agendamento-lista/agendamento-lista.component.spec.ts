import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendamentoListaComponent } from './agendamento-lista.component';

describe('AgendamentoListaComponent', () => {
  let component: AgendamentoListaComponent;
  let fixture: ComponentFixture<AgendamentoListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendamentoListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgendamentoListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
