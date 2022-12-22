import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IBeneficiarioDto } from '../interfaces/IBeneficiarioDto';

@Component({
  selector: 'app-beneficiario-editar',
  templateUrl: './beneficiario-editar.component.html',
  styleUrls: ['./beneficiario-editar.component.css']
})
export class BeneficiarioEditarComponent {
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
            senha: this.beneficiario.senha,
            idBeneficiario: this.idRecebido,
            nome: this.beneficiario.nome,
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

  salvar() {
    if (this.validarInformacoes()) {
      if (this.beneficiario.idBeneficiario != 0) {

        this.http.patch(`https://localhost:7275/api/Beneficiarios/Atualizar/${this.idRecebido}`, this.beneficiario)
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
  }

  validarInformacoes(): boolean {
    if (this.beneficiario.nome == '') {
      return false;
    }

    // VALIDAR COM REGEX

    return true;
  }

  sair() {
    this.router.navigate(['beneficiarios/listartodos']);
  }
}
