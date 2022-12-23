import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IProfissionalDto } from '../../../interfaces/IProfissionalDto';

@Component({
  selector: 'app-profissional-editar',
  templateUrl: './profissional-editar.component.html',
  styleUrls: ['./profissional-editar.component.css']
})
export class ProfissionalEditarComponent {
  profissional!: IProfissionalDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/api/Profissional/ListarPorId/${this.idRecebido}`)
        .subscribe((data) => {

          this.profissional = data as IProfissionalDto;

          this.profissional = {
            idProfissional: this.idRecebido,
            nome: this.profissional.nome,
            telefone: this.profissional.telefone,
            endereco: this.profissional.endereco,
            ativo: this.profissional.ativo
          }
        });
    }
  }

  salvar() {
    if (this.validarInformacoes()) {
      if (this.profissional.idProfissional != 0) {

        this.http.patch(`https://localhost:7275/api/Profissional/Atualizar/${this.idRecebido}`, this.profissional)
          .subscribe((data) => {
            this.router.navigate(['profissional']);
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
    this.router.navigate(['profissional']);
  }
}
