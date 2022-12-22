import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAgendamentoDto } from 'src/app/interfaces/IAgendamentoDto';


@Component({
  selector: 'app-agendamento-excluir',
  templateUrl: './agendamento-excluir.component.html',
  styleUrls: ['./agendamento-excluir.component.css']
})
export class AgendamentoExcluirComponent {
  agendamento!: IAgendamentoDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/api/Agendamento/ListarPorId/${this.idRecebido}`)
        .subscribe((data) => {

          const agendamento = data as IAgendamentoDto;
          /*
          this.agendamento = {
            nome: agendamento.nome,
            idAgendamento: agendamento.idRecebido,
            idBeneficiarioNavigation: this.agendamento.idBeneficiarioNavigation,
            idHospitalNavigation: this.agendamento.idHospitalNavigation,
            idEspecialidadeNavigation: this.agendamento.idEspecialidadeNavigation,
            idProfissionalNavigation: this.agendamento.idProfissionalNavigation,
            idHospital: this.agendamento.idHospital,
            idEspecialidade: this.agendamento.idEspecialidade,
            idProfissional: this.agendamento.idProfissional,
            dataHoraAgendamento: this.agendamento.dataHoraAgendamento,
            idBeneficiario: this.agendamento.idBeneficiario,
            ativo: this.agendamento.ativo,
          }
          */
         this.agendamento = agendamento
        });
    }
  }

  apagar() {
    if (this.agendamento.idAgendamento !== 0) {
      this.http.delete(`https://localhost:7275/api/Agendamento/Excluir/${this.idRecebido}`)
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

  sair() {
    this.router.navigate(['agendamento/listartodos']);
  }
}
