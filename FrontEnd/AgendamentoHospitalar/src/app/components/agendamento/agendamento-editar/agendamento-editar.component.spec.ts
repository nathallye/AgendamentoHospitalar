import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendamentoEditarComponent } from './agendamento-editar.component';

describe('AgendamentoEditarComponent', () => {
  let component: AgendamentoEditarComponent;
  let fixture: ComponentFixture<AgendamentoEditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendamentoEditarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgendamentoEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
