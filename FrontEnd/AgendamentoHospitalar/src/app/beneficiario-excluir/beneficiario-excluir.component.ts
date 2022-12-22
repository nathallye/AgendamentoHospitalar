import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IBeneficiarioDto } from '../interfaces/IBeneficiarioDto';

@Component({
  selector: 'app-beneficiario-excluir',
  templateUrl: './beneficiario-excluir.component.html',
  styleUrls: ['./beneficiario-excluir.component.css']
})
export class BeneficiarioExcluirComponent {
  beneficiario!: IBeneficiarioDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/api/Beneficiarios/ListarPorId/${this.idRecebido}`)
        .subscribe((data) => {

          this.beneficiario = data as IBeneficiarioDto;

          this.beneficiario = {
            idBeneficiario: this.idRecebido,
            nome: this.beneficiario.nome,
            senha: this.beneficiario.senha,
            cpf: this.beneficiario.cpf,
            numeroCarteirinha: this.beneficiario.numeroCarteirinha,
            telefone: this.beneficiario.telefone,
            email: this.beneficiario.email,
            endereco: this.beneficiario.endereco,
            ativo: this.beneficiario.ativo
          }
        });
    }
  }

  apagar() {
    if (this.beneficiario.idBeneficiario !== 0) {
      this.http.delete(`https://localhost:7275/api/Beneficiarios/Excluir/${this.idRecebido}`)
      .subscribe((data) => {
        this.router.navigate(['beneficiarios/listartodos']);
      });

    } else {
      console.log('Erro na validação');
      // TRATAMENTO DE ERRO
      // ALERTA
      // BORDA VERMELHA
    }
  }

  sair() {
    this.router.navigate(['beneficiarios/listartodos']);
  }
}
