using RestAPISample.Dto;
using RestAPISample.Entity;

namespace RestAPISample.services
{
    public class RegisterService
    {
        public BaseDto RegisterUser(string name, int age, string email)
        {
            var user = new UserEntity(age, name, email);

            if (age < 18)
                return new BaseDto(406, "Voce precisa ter no minimo 18 anos", null);

            if (email.Contains("@") == false)
                return new BaseDto(406, "Email invalido", null);

            if (name.Length < 5)
                return new BaseDto(406, "Nome muito curto", null);

            return new BaseDto(200, "Conta Criada com sucesso", null);
        }
    }
}
