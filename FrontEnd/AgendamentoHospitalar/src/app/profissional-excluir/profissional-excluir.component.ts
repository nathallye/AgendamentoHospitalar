import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IProfissionalDto } from '../interfaces/IProfissionalDto';

@Component({
  selector: 'app-profissional-excluir',
  templateUrl: './profissional-excluir.component.html',
  styleUrls: ['./profissional-excluir.component.css']
})
export class ProfissionalExcluirComponent {
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
        .get(`https://localhost:7275/api/Beneficiarios/ListarPorId/${this.idRecebido}`)
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

  apagar() {
    if (this.profissional.idProfissional !== 0) {
      this.http.delete(`https://localhost:7275/api/Profissional/Excluir/${this.idRecebido}`)
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

  sair() {
    this.router.navigate(['profissionais/listartodos']);
  }
}
