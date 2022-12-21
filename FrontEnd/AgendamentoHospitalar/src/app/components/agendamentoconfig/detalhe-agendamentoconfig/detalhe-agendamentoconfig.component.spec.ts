import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalheAgendamentoconfigComponent } from './detalhe-agendamentoconfig.component';

describe('DetalheAgendamentoconfigComponent', () => {
  let component: DetalheAgendamentoconfigComponent;
  let fixture: ComponentFixture<DetalheAgendamentoconfigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalheAgendamentoconfigComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetalheAgendamentoconfigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
