export interface IMenu {
   id: number,
   name: string,
   route: string | undefined,
   subroute: IMenu[] | undefined,
   access: string[]
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

export interface IError{
   code: number,
   description: string
}

export interface IContact{
   titre: string,
   mail: string,
   sujet: string,
   content: string,
   btnenvoi: string,
   description: string
}

export interface IAide{
   //TODO Faire reste
   questions: IQuestion[]
}

export interface IQuestion{
   question: string,
   reponse: string
}
