import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IBeneficiarioDto } from '../interfaces/IBeneficiarioDto';

@Component({
  selector: 'app-beneficiario-criar',
  templateUrl: './beneficiario-criar.component.html',
  styleUrls: ['./beneficiario-criar.component.css']
})
export class BeneficiarioCriarComponent {
  beneficiario: IBeneficiarioDto = {
  idBeneficiario:0,
  nome: '',
  cpf: '',
  numeroCarteirinha: '',
  telefone: '',
  email: '',
  endereco: '',
  senha: '',
  ativo: true
};
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {

  }


  salvar() {
    if (this.validarInformacoes()) {
      if (this.beneficiario.idBeneficiario == 0) {
        console.log(this.beneficiario)
        this.http.post('https://localhost:7275/api/Beneficiarios/Criar', this.beneficiario)
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
