import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfissionalCriarComponent } from './profissional-criar.component';

describe('ProfissionalCriarComponent', () => {
  let component: ProfissionalCriarComponent;
  let fixture: ComponentFixture<ProfissionalCriarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfissionalCriarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfissionalCriarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
