import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendamentoExcluirComponent } from './agendamento-excluir.component';

describe('AgendamentoExcluirComponent', () => {
  let component: AgendamentoExcluirComponent;
  let fixture: ComponentFixture<AgendamentoExcluirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendamentoExcluirComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgendamentoExcluirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
