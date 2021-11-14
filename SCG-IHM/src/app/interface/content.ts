export interface IMenu {
   id: number,
   name: string,
   route: string
}

export interface IConnect{
   title: string,
   description: string,
   mailplaceholder: string,
   passplaceholder: string,
   bouton: string,
   envtestdesc: string,
   erreurconnection: string
}

export interface IAide{
   //TODO Faire reste
   questions: IQuestion[]
}

export interface IQuestion{
   question: string,
   reponse: string
}
