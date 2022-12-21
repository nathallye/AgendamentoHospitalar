import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarAgendamentoconfigComponent } from './criar-agendamentoconfig.component';

describe('CriarAgendamentoconfigComponent', () => {
  let component: CriarAgendamentoconfigComponent;
  let fixture: ComponentFixture<CriarAgendamentoconfigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CriarAgendamentoconfigComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CriarAgendamentoconfigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
