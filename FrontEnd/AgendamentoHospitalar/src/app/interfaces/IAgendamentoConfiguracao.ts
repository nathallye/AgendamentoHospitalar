export default interface IAgendamentoConfiguracaoDTO {
  idConfiguracao: number;
  nomeHospital:string;
  nomeEspecialidade:string;
  nomeProfissional:string;
  dataHoraInicioAtendimento:Date;
  dataHoraFinalAtendimento:Date;
}
