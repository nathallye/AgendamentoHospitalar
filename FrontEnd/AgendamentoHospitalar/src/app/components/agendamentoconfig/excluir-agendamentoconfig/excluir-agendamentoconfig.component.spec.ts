import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExcluirAgendamentoconfigComponent } from './excluir-agendamentoconfig.component';

describe('ExcluirAgendamentoconfigComponent', () => {
  let component: ExcluirAgendamentoconfigComponent;
  let fixture: ComponentFixture<ExcluirAgendamentoconfigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExcluirAgendamentoconfigComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExcluirAgendamentoconfigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
