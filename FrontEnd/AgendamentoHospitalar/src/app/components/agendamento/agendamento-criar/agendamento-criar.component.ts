import { IHospitalDto } from './../../../interfaces/IHospitalDto';
import { IProfissionalDto } from './../../../interfaces/IProfissionalDto';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import IEspecialidadeDTO from 'src/app/interfaces/IEspecialidadeDTO';
import { IAgendamentoDto } from 'src/app/interfaces/IAgendamentoDto';

@Component({
  selector: 'app-agendamento-criar',
  templateUrl: './agendamento-criar.component.html',
  styleUrls: ['./agendamento-criar.component.css']
})
export class AgendamentoCriarComponent {
    beneficiario!: IAgendamentoDto;
    idRecebido!: number;
    listarEspecialidades: IEspecialidadeDTO[] = [];
    listaProfissional: IProfissionalDto[] = [];
    listaHospital: IHospitalDto[] = [];
    IAgendamentoDto = {
    dataHoraAgendamento: new Date(),
    idBeneficiario: '',
    idHospital: '',
    idProfissional: '',
    idEspecialidade: '',
 }


  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }


  ngOnInit(): void {
    this.AgendamentoCriarComponent

    }
  }
/*
  nome: string;
  idAgendamento: number,
  idBeneficiario: number,
  idHospital: number,
  idEspecialidade: number,
  idProfissional: number,
  dataHoraAgendamento: Date,
  ativo: boolean,
  idBeneficiarioNavigation: IBeneficiarioDto,
  idHospitalNavigation: IHospitalDto,
  idEspecialidadeNavigation: IEspecialidadeDTO,
  idProfissionalNavigation: IProfissionalDto
  */
  salvar() {
    if (this.validarInformacoes()) {
      if (this.agendamento.idAgendamento == 0) {

        this.http.post('https://localhost:7275/api/Agendamentos/Criar', this.agendamento)
          .subscribe((data) => {
            this.router.navigate(['agendamento/listartodos']);
          });
      } else {
        console.log('Erro na validação');
        // TRATAMENTO DE ERRO
        // ALERTA
        // BORDA VERMELHA
      }
    }
  }

  validarInformacoes(): boolean {
    if (this.agendamento.nome == '') {
      return false;
    }

    // VALIDAR COM REGEX

    return true;
  }

  sair() {
    this.router.navigate(['agendamentos/listartodos']);
  }
}
