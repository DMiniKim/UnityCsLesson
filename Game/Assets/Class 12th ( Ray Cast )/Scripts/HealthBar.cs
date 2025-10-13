using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float maxHealth = 354f;
    [SerializeField] float currenthealth;

    [SerializeField] Slider slider;
    private Coroutine damageCoroutine;
    void Start()
    {
        currenthealth = maxHealth;
        UpdateUI();
      
    }


    void UpdateUI()
    {        
        slider.value = currenthealth / maxHealth;
        Debug.Log(slider.value);
    }
    public void Damage(float attack)
    {
        float targetHealth = currenthealth - attack;

        // 현재 데미지 이펙트 중복 방지
        if (damageCoroutine != null)
            StopCoroutine(damageCoroutine);

        damageCoroutine = StartCoroutine(DamageEffect(targetHealth));
    }
    IEnumerator DamageEffect(float targetHealth)
    {
        // targetHealth가 음수가 되지 않도록 제한
        targetHealth = Mathf.Max(targetHealth, 0f);

        // 현재 체력에서 목표 체력까지 부드럽게 감소
        while (currenthealth > targetHealth)
        {
            // 1프레임마다 조금씩 깎음 (속도 조절 가능)
            currenthealth -= maxHealth * 0.01f;  // 1%씩 줄이기 예시

            // 목표치보다 작아지면 고정
            if (currenthealth < targetHealth)
                currenthealth = targetHealth;

            UpdateUI();

            yield return null;  // 다음 프레임까지 대기
        }
    }
}