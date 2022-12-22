export default interface IAgendamentoConfiguracaoDTO {
  idConfiguracao: number;
  nomeHospital:string;
  idHospital:number;
  nomeEspecialidade:string;
  idEspecialidade:number;
  nomeProfissional:string;
  idProfissional:number;
  dataHoraInicioAtendimento:Date;
  dataHoraFinalAtendimento:Date;
}
