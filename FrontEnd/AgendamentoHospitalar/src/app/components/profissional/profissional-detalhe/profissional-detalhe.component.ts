import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IProfissionalDto } from '../../../interfaces/IProfissionalDto';

@Component({
  selector: 'app-profissional-detalhe',
  templateUrl: './profissional-detalhe.component.html',
  styleUrls: ['./profissional-detalhe.component.css']
})
export class ProfissionalDetalheComponent {
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

  fechar() {
    this.router.navigate(['profissional']);
  }
}
