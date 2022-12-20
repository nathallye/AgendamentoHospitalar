import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IProfissionalDto } from '../interfaces/IProfissionalDto';

@Component({
  selector: 'app-profissional-criar',
  templateUrl: './profissional-criar.component.html',
  styleUrls: ['./profissional-criar.component.css']
})
export class ProfissionalCriarComponent {
  profissional!: IProfissionalDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    this.profissional = {
      idProfissional: this.idRecebido ?? 0,
      nome: '',
      telefone: '',
      endereco: '',
      ativo: true
    }
  }

  salvar() {
    if (this.validarInformacoes()) {
      if (this.profissional.idProfissional == 0) {

        this.http.post('https://localhost:7275/api/Profissionais/Criar', this.profissional)
          .subscribe((data) => {
            this.router.navigate(['profissionais/listartodos']);
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
    if (this.profissional.nome == '') {
      return false;
    }

    // VALIDAR COM REGEX

    return true;
  }

  sair() {
    this.router.navigate(['profissionais/listartodos']);
  }
}
