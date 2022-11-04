export class BaseModel<T>
{
  isSuccess: boolean=false;
  data: Array<T>;
  errors: string[]=[];
}

