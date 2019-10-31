public class Solution {
    public string DefangIPaddr(string address) {
        
        
        string IPAddress = "";
        char[] addresschar = address.ToCharArray();
        for (int i = 0; i < addresschar.Length; i++)
        {
            if(addresschar[i] == '.')
            {
                IPAddress = IPAddress + "[.]";
            } 
            else 
            {
                IPAddress = IPAddress + addresschar[i];
            }
        }
        return IPAddress;
    }
}